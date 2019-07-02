//------------------------------------------------------------------------------
// <copyright file="Check.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Exceptions
{
    /// <summary>
    /// Una clase que ayuda a controlar precondiciones, postcondiciones e invariantes levantando excepciones si no se cumplen las afirmaciones correspondientes.
    /// </summary>
    public class Check
    {
        /// <summary>
        /// Controla una precondición; en caso que no se cumpla levanta una excepción <see cref="PreconditionException"/>; no hace nada en caso contrario.
        /// </summary>
        /// <param name="condition">La condición a comprobar.</param>
        /// <param name="message">El mensaje a agregar en la excepción que se levanta si la condición no se cumple.</param>
        public static void Precondition(bool condition, string message)
        {
            if (!condition)
            {
                throw new PreconditionException(message);
            }
        }

        /// <summary>
        /// Controla una precondición; en caso que no se cumpla levanta una excepción <see cref="PreconditionException"/>; no hace nada en caso contrario.
        /// </summary>
        /// <param name="condition">La condición a comprobar.</param>
        public static void Precondition(bool condition)
        {
            Precondition(condition, "Precondición insatisfecha");
        }

        /// <summary>
        /// Controla una postconditión; en caso que no se cumpla levanta una excepción <see cref="PostconditionException"/>; no hace nada en caso contrario.
        /// </summary>
        /// <param name="condition">La condición a comprobar.</param>
        /// <param name="message">El mensaje a agregar en la excepción que se levanta si la condición no se cumple.</param>
        public static void Postcondition(bool condition, string message)
        {
            if (!condition)
            {
                throw new PostconditionException(message);
            }
        }

        /// <summary>
        /// Controla una postcondición; en caso que no se cumpla levanta una excepción <see cref="PostconditionException"/>; no hace nada en caso contrario.
        /// </summary>
        /// <param name="condition">La condición a comprobar.</param>
        public static void Postcondition(bool condition)
        {
            Postcondition(condition, "Postcondición insatisfecha");
        }

        /// <summary>
        /// Controla una invariante; en caso que no se cumpla levanta una excepción <see cref="InvariantException"/>; no hace nada en caso contrario.
        /// </summary>
        /// <param name="condition">La condición a comprobar.</param>
        /// <param name="message">El mensaje a agregar en la excepción que se levanta si la condición no se cumple.</param>
        public static void Invariant(bool condition, string message)
        {
            if (!condition)
            {
                throw new InvariantException(message);
            }
        }

        /// <summary>
        /// Controla una invariante; en caso que no se cumpla levanta una excepción <see cref="PostconditionException"/>; no hace nada en caso contrario.
        /// </summary>
        /// <param name="condition">La condición a comprobar.</param>
        public static void Invariant(bool condition)
        {
            Invariant(condition, "Invariante insatisfecha");
        }

        /// <summary>
        /// La excepción levantada si no se cumple una precondición. Esta excepción es levantada en los métodos <see cref="Check.Precondition(bool)"/> y
        /// <see cref="Check.Precondition(bool, string)"/>.
        /// </summary>
        public class PreconditionException : Exception
        {
            /// <summary>
            /// Crea una nueva excepción.
            /// </summary>
            /// <returns>La excepción recién creada.</returns>
            public PreconditionException()
                : base()
            {
                // Intencionalmente en blanco
            }

            /// <summary>
            /// Crea una nueva excepción con el mesaje pasado como argumento.
            /// </summary>
            /// <param name="message">El mensaje de la nueva excepción.</param>
            /// <returns>La excepción recién creada.</returns>
            public PreconditionException(string message)
                : base(message)
            {
                // Intencionalmente en blanco
            }
        }

        /// <summary>
        /// La excepción levantada si no se cumple una postcondición. Esta excepción es levantada en los métodos <see cref="Check.Postcondition(bool)"/> y
        /// <see cref="Check.Postcondition(bool, string)"/>
        /// </summary>
        public class PostconditionException : Exception
        {
            /// <summary>
            /// Create una nueva excepción.
            /// </summary>
            /// <returns>La excepción recién creada.</returns>
            public PostconditionException()
                : base()
            {
                // Intencionalmente en blanco.
            }

            /// <summary>
            /// Crea una nueva excepción con el mesaje pasado como argumento. Esta excepción es levantada en los métodos <see cref="Check.Invariant(bool)"/> y
            /// <see cref="Check.Invariant(bool, string)"/>
            /// </summary>
            /// <param name="message">El mensaje de la nueva excepción.</param>
            /// <returns>La excepción recién creada.</returns>
            public PostconditionException(string message)
                : base(message)
            {
                // Intencionalmente en blanco
            }
        }

        /// <summary>
        /// La excepción levantada si no se cumple una invariante.
        /// </summary>
        public class InvariantException : Exception
        {
            /// <summary>
            /// Create una nueva excepción.
            /// </summary>
            /// <returns>La excepción recién creada.</returns>
            public InvariantException()
                : base()
            {
                // Intencionalmente en blanco
            }

            /// <summary>
            /// Crea una nueva excepción con el mesaje pasado como argumento.
            /// </summary>
            /// <param name="message">El mensaje de la nueva excepción.</param>
            /// <returns>La excepción recién creada.</returns>
            public InvariantException(string message)
                : base(message)
            {
                // Intencionalmente en blanco
            }
        }
    }
}