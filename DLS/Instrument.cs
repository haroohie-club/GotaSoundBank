using System.Collections.Generic;

namespace GotaSoundBank.DLS
{
    /// <summary>
    /// Instrument.
    /// </summary>
    public class Instrument
    {
        /// <summary>
        /// Instrument name.
        /// </summary>
        public string Name = "";

        /// <summary>
        /// Bank Id.
        /// </summary>
        public uint BankId;

        /// <summary>
        /// Instrument Id.
        /// </summary>
        public uint InstrumentId;

        /// <summary>
        /// Regions.
        /// </summary>
        public List<Region> Regions = new();
    }
}
