using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Linked.Areas.Identity.Data;
using Linked.Models;

  /// <summary>
  /// Los controladores son los encargados de traducir las entradas de los usuarios en acciones a ser llevadas a cabo por el modelo.
  /// Es decir, maneja las interacciones con los usuarios y provee un mecanismo por el cual se produce un cambio en el estado del modelo.
  /// Uno de los propósitos en MVC es separar el modelo de las vistas a modo de que cambios en las vistas no se tengan que verse reflejadas
  /// en el modelo y viceversa, en otras palabras, modularizar la aplicación.
  ///
  /// Esta clase hereda de PageModel de modo que extiende sus propiedades y comportamiento sin necesidad de volver a implementarlo.
  /// Por lo tanto, la clase RegisterModel tiene una clasificación jerárquica por debajo de PageModel.
  ///
  ///Patrones:
  /// Expert / Creator - Debido a que esta clase es experta en la información necesaria para crear un Cliente es que se le asigna dicha 
  /// responsabilidad. De este modo no solo se mantiene la cohesión alta sino que también se mantiene a la información encapsulada. 
  /// El patrón Creator es quien nos ayudó a identificar el hecho de que la responsabilidad de crear los Clients caiga en esta clase.
  ///
  /// Colaboradores: Client, SignInManager, UserManager, ILogger, IEmailSender y Linked.Areas.Identity.Data.IdentityContext  
  ///
  /// Principios:
  /// SRP- La única responsabilidad que tiene esta clase es de crear Clients, dicha responsabilidad se le es asignada a través de los 
  /// patrones Expert y Creator.
  ///
  /// ISP: RegisterModel implementa todos los tipos (IAsyncPageFilter, IFilterMetadata, IPageFilter) expresados explícitamente en las 
  /// interfaces implementadas por el supertipo PageModel. Por esta razón RegisterModel no se ve forzada a implementar tipos que no 
  /// utiliza, ya que las interfaces implementadas aseguran el funcionamiento del controlador.
  ///
  /// OCP - PageModel está abierta a la extensión y cerrada a la modificación porque pudimos extenderla con RegisterModel sin necesidad de
  /// modificarla.
  /// LSP -  PageModel se puede sustituir por su subtipo RegisterModel, ya que RegisterModel extiende el comportamiento de PageModel, 
  /// respetando los tipos en PageModel. var result = await _userManager.CreateAsync(user, Input.Password); En el controlador Register 
  /// se ve un uso directo de LSP, en que para el método CreateAsync, que toma como parámetro un objeto del tipo, ApplicationUser, se 
  /// utilizan instancias de Client o Technician que son subtipos de ApplicationUser.
  /// </summary>
   
namespace Linked.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Full name")]
            public string Name { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new Client {
                    Name = Input.Name,
                    UserName = Input.Email,
                    Email = Input.Email,
                    DOB = DateTime.Now,
                };

                user.AssignRole(_userManager, IdentityData.NonAdminRoleNames[0]);

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
