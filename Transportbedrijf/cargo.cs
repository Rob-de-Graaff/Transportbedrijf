using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Transportbedrijf
{
    class Cargo
    {
        private string name;
        private double pricePerVolumeNonLiquid;
        private double pricePerWeigthNonLiquid;
        private double pricePerVolumeLiquid;
        private double pricePerWeigtLiquid;
        private double transportationCostsPerKm;
        private double surtaxForeignRoads;
        private double surtaxCustomsFees;
        private double surtaxCustomsFeesMin;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double PricePerVolumeNonLiquid
        {
            get { return pricePerVolumeNonLiquid; }
            set { pricePerVolumeNonLiquid = value; }
        }

        public double PricePerWeightNonLiquid
        {
            get { return pricePerWeigthNonLiquid; }
            set { pricePerWeigthNonLiquid = value; }
        }

        public double PricePerVolumeLiquid
        {
            get { return pricePerVolumeLiquid; }
            set { pricePerVolumeLiquid = value; }
        }

        public double PricePerWeigthLiquid
        {
            get { return pricePerWeigtLiquid; }
            set { pricePerWeigtLiquid = value; }
        }

        public double TransportationCostsPerKm
        {
            get { return transportationCostsPerKm; }
            set { transportationCostsPerKm = value; }
        }

        public double SurtaxForeignRoads
        {
            get { return surtaxForeignRoads; }
            set { surtaxForeignRoads = value; }
        }

        public double SurtaxCustomsFees
        {
            get { return surtaxCustomsFees; }
            set { surtaxCustomsFees = value; }
        }

        public double SurtaxCustomsFeesMin
        {
            get { return surtaxCustomsFeesMin; }
            set { surtaxCustomsFeesMin = value; }
        }

        public Cargo(string cargoName, double cargoPricePerVolumeNonLiquid, double cargoPricePerWeightNonLiquid,
            double cargoPricePerVolumeLiquid, double cargoPricePerWeightLiquid, double cargoSurtaxForeignRoads,
            double cargoSurtaxCustomsFees, double cargoSurtaxCustomsFeesMin)
        {
            name = cargoName;
            pricePerVolumeNonLiquid = cargoPricePerVolumeNonLiquid;
            pricePerWeigthNonLiquid = cargoPricePerWeightNonLiquid;
            pricePerVolumeLiquid = cargoPricePerVolumeLiquid;
            pricePerWeigtLiquid = cargoPricePerWeightLiquid;
            surtaxForeignRoads = cargoSurtaxForeignRoads;
            surtaxCustomsFees = cargoSurtaxCustomsFees;
            surtaxCustomsFeesMin = cargoSurtaxCustomsFeesMin;
        }
    }
}
