using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportbedrijf
{
    public partial class Form1 : Form
    {
        private Cargo _newCargo;
        private double _priceTotal, _pricePerVolume, _pricePerWeight, _valueCargo, _surtaxForeignRoads , _customsFees;
        private int resultVolume, distanceTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _newCargo = new Cargo("standaard", 0.80, 0.55, 1.25, 0.45, 1.45, 1.035, 45);

            labelVolumePriceNonLiquid.Text = _newCargo.PricePerVolumeNonLiquid.ToString();

            labelWeightPriceNonLiquid.Text = _newCargo.PricePerWeightNonLiquid.ToString();

            labelVolumePriceLiquid.Text = _newCargo.PricePerVolumeLiquid.ToString();

            labelWeightPriceLiquid.Text = _newCargo.PricePerWeigthLiquid.ToString();

            labeltransportationCosts.Text = _newCargo.TransportationCostsPerKm.ToString();

            labelSurtaxForeignRoads.Text = _newCargo.SurtaxForeignRoads.ToString();

            labelSurtaxCustomsFees.Text = _newCargo.SurtaxCustomsFees.ToString();

            labelSurtaxCustomsFeesMin.Text = _newCargo.SurtaxCustomsFeesMin.ToString();
            
            labelTicketsTotal.Text =
                $"totaal = Volume-component * volume + Gewicht-component * gewicht + aantal KM * (volumeprice + weigthprice) + \ntoeslagbl(aantalKMBL * 1.45%) + douanekosten(valueCargo(€0.80 * volume + €0.55 * weigth || €1.25 * volume + €0.45 * weigth)* 1.035%)";
            
            labelPriceTotal.Text = $@"Totaal: € {Math.Round(_priceTotal, 2)},-";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            // Resets values every button click
            _priceTotal = 0;
            _pricePerVolume = 0;
            _pricePerWeight = 0;
            _valueCargo = 0;
            _surtaxForeignRoads = 0;
            _customsFees = 0;
            resultVolume = 0;
            distanceTotal = 0;

            // Checks if any cargo is selected
            if (CheckSelection())
            {
                // Sets the correct transportation costs per cargo type
                if (radioButtonNonLiquids.Checked)
                {
                    _pricePerVolume = _newCargo.PricePerVolumeNonLiquid;
                    _pricePerWeight = _newCargo.PricePerWeightNonLiquid;

                    _newCargo.TransportationCostsPerKm = _pricePerVolume + _pricePerWeight;
                }
                else
                {
                    _pricePerVolume = _newCargo.PricePerVolumeLiquid;
                    _pricePerWeight = _newCargo.PricePerWeigthLiquid;

                    _newCargo.TransportationCostsPerKm = _pricePerVolume + _pricePerWeight;
                }

                labeltransportationCosts.Text = _newCargo.TransportationCostsPerKm.ToString();

                // Checks all user input in all textboxes
                if (int.TryParse(textBoxVolume.Text, out int resultVolume) && resultVolume > 0)
                {
                    if (int.TryParse(textBoxWeight.Text, out int resultWeight) && resultWeight > 0)
                    {
                        if (int.TryParse(textBoxDistanceNL.Text, out int resultDistanceNL))
                        {
                            if (int.TryParse(textBoxDistanceForeign.Text, out int resultDistanceForeign))
                            {
                                distanceTotal = resultDistanceNL + resultDistanceForeign;
                                _valueCargo = resultVolume * _pricePerVolume + resultWeight + _pricePerWeight;
                                _customsFees = _valueCargo * _newCargo.SurtaxCustomsFees;

                                _priceTotal += resultVolume * _pricePerVolume;
                                _priceTotal += resultWeight + _pricePerWeight;
                                _priceTotal += distanceTotal * _newCargo.TransportationCostsPerKm;
                                _surtaxForeignRoads = resultDistanceForeign * _newCargo.SurtaxForeignRoads;
                                _priceTotal += _surtaxForeignRoads;
                               
                                // Checks if customs fees is smaller then the minimum
                                if (_customsFees < _newCargo.SurtaxCustomsFeesMin)
                                {
                                    _customsFees = _newCargo.SurtaxCustomsFeesMin;
                                }

                                _priceTotal += _customsFees;

                                labelTicketsTotal.Text = $"totaal = € {_pricePerVolume} * {resultVolume} + € {_pricePerWeight} * {resultWeight} + " +
                                                         $"{distanceTotal} * (€ {_pricePerVolume} + € {_pricePerWeight}) + \n" +
                                                         $"€ {_surtaxForeignRoads} =({resultDistanceForeign} * {(_newCargo.SurtaxForeignRoads-1)*100}%) + " +
                                                         $"€ {_customsFees} = (€ {_valueCargo} = " +
                                                         $"({resultVolume} * € {_pricePerVolume} + {resultWeight} + € {_pricePerWeight}) * {(_newCargo.SurtaxCustomsFees-1)*100:0.0}%)";
            
                                labelPriceTotal.Text = $@"Totaal: € {Math.Round(_priceTotal, 2):0.00},-";
                            } 
                            else
                            {
                                MessageBox.Show($@"Distance Foreign must contain only numbers");
                            }
                        }  
                        else
                        {
                            MessageBox.Show($@"Distance NL must contain only numbers");
                        }
                    }
                    else
                    {
                        MessageBox.Show($@"Weight must contain only numbers > 0");
                    }
                }
                else
                {
                    MessageBox.Show($@"Volume must contain only numbers > 0");
                }
            }
            else
            {
                MessageBox.Show($@"Please select a type of cargo");
            }
        }

        private bool CheckSelection()
        {
            int radioButtonCounter = 0;
            foreach (RadioButton control in panelCargoTypeSelection.Controls.OfType<RadioButton>())
            {
                if (control.Checked)
                {
                    radioButtonCounter++;
                }
            }

            if (radioButtonCounter == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
