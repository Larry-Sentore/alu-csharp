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
        /// The name of the zombie (private field).
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Gets or sets the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

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
/// <summary>
/// Get the health of the zombie.
/// </summary>
/// <returns>Returns the health value of the zombie.</returns>

        
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
