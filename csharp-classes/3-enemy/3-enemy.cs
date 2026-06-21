using System;

namespace Enemies
{
    /// <summary>
    /// Represents a zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// The health of the zombie (private field).
        /// </summary>
        private int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with default health set to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with a specified health value.
        /// </summary>
        /// <param name="value">The initial health value of the zombie. Must be >= 0.</param>
        /// <exception cref="ArgumentException">Thrown when value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>
        /// Gets the health value of the zombie.
        /// </summary>
        /// <returns>The zombie's health.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
