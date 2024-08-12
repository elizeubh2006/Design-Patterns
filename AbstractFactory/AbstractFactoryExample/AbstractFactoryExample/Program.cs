namespace AbstractFactoryExample
{
    internal class Program
    {

        //Define the Abstract Product Interface
        public interface IRelatedClassReport
        {
            void GenerateReport();
        }

        #region Classes with all sort of reports
        //Implement Concrete Products for Each Family
        //Operational and Administrative Costs Reports
        public class FixedAndVariableCostsReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Fixed and Variable Costs Report...");
            }
        }

        public class OperationalExpensesReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Operational Expenses Report...");
            }
        }

        public class AdministrativeExpensesReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Administrative Expenses Report...");
            }
        }

        public class BudgetDeviationAnalysisReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Budget Deviation Analysis Report...");
            }
        }

        public class CostCenterAnalysisReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Cost Center Analysis Report...");
            }
        }

        //Production and Materials Costs Reports
        public class RawMaterialsCostsReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Raw Materials Costs Report...");
            }
        }

        public class ProductionEfficiencyReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Production Efficiency Report...");
            }
        }

        public class VehicleCostReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Vehicle Cost Report...");
            }
        }

        public class ComponentCostReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Component Cost Report...");
            }
        }

        public class WasteReductionReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Waste Reduction Report...");
            }
        }

        public class EconomiesOfScaleReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Economies of Scale Report...");
            }
        }

        //  Logistics and Transportation Costs Reports
        public class LogisticsAndTransportationCostsReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Logistics and Transportation Costs Report...");
            }
        }

        public class InventoryAndStorageCostsReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Inventory and Storage Costs Report...");
            }
        }

        public class JustInTimeSupplyAnalysisReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Just-in-Time Supply Analysis Report...");
            }
        }

        //Labor and Supplier Costs Reports
        public class LaborCostsReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Labor Costs Report...");
            }
        }

        public class SupplierPerformanceReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Supplier Performance Report...");
            }
        }

        public class CostBenchmarkingReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Cost Benchmarking Report...");
            }
        }

        //Maintenance and Equipment Costs Reports
        public class EquipmentTotalCostOfOwnershipReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Equipment Total Cost of Ownership Report...");
            }
        }

        public class PreventiveAndCorrectiveMaintenanceCostsReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Preventive and Corrective Maintenance Costs Report...");
            }
        }

        public class ReprocessingAndScrapCostsReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Reprocessing and Scrap Costs Report...");
            }
        }

        //Energy and Environmental Costs Reports
        public class EnergyCostsReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Energy Costs Report...");
            }
        }

        public class EnvironmentalCostsImpactReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Environmental Costs Impact Report...");
            }
        }

        //Warranty and Repair Costs Reports
        public class WarrantyAndRepairCostsReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Warranty and Repair Costs Report...");
            }
        }

        //Innovations and Technologies Costs Reports
        public class TechnologyCostBenefitReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Technology Cost-Benefit Report...");
            }
        }

        //Product and Profitability Costs Reports
        public class ProductProfitabilityAnalysisReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Product Profitability Analysis Report...");
            }
        }

        public class ImportedInputsCostsAnalysisReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Imported Inputs Costs Analysis Report...");
            }
        }

        public class FutureCostsProjectionsReport : IRelatedClassReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Future Costs Projections Report...");
            }
        }
        #endregion



        //Define the Abstract Factory Interface
        public interface IDirectoryReportAbstractFactory
        {
            IRelatedClassReport CreateInstanceOf(string concreteClassName);
        }

        #region All Factories
        //Implement Concrete Factories for Each Family
        //Operational and Administrative Costs Report Factory
        public class OperationalAndAdministrativeCostsReportFactory : IDirectoryReportAbstractFactory
        {
            public IRelatedClassReport CreateInstanceOf(string concreteClassName)
            {
                return concreteClassName switch
                {
                    "FixedAndVariableCosts" => new FixedAndVariableCostsReport(),
                    "OperationalExpenses" => new OperationalExpensesReport(),
                    "AdministrativeExpenses" => new AdministrativeExpensesReport(),
                    "BudgetDeviationAnalysis" => new BudgetDeviationAnalysisReport(),
                    "CostCenterAnalysis" => new CostCenterAnalysisReport(),
                    _ => throw new ArgumentException("Invalid report type"),
                };
            }
        }

        //Production and Materials Costs Report Factory
        public class ProductionAndMaterialsCostsReportFactory : IDirectoryReportAbstractFactory
        {
            public IRelatedClassReport CreateInstanceOf(string concreteClassName)
            {
                return concreteClassName switch
                {
                    "RawMaterialsCosts" => new RawMaterialsCostsReport(),
                    "ProductionEfficiency" => new ProductionEfficiencyReport(),
                    "VehicleCost" => new VehicleCostReport(),
                    "ComponentCost" => new ComponentCostReport(),
                    "WasteReduction" => new WasteReductionReport(),
                    "EconomiesOfScale" => new EconomiesOfScaleReport(),
                    _ => throw new ArgumentException("Invalid report type"),
                };
            }
        }

        //Logistics and Transportation Costs Report Factory
        public class LogisticsAndTransportationCostsReportFactory : IDirectoryReportAbstractFactory
        {
            public IRelatedClassReport CreateInstanceOf(string concreteClassName)
            {
                return concreteClassName switch
                {
                    "LogisticsAndTransportationCosts" => new LogisticsAndTransportationCostsReport(),
                    "InventoryAndStorageCosts" => new InventoryAndStorageCostsReport(),
                    "JustInTimeSupplyAnalysis" => new JustInTimeSupplyAnalysisReport(),
                    _ => throw new ArgumentException("Invalid report type"),
                };
            }
        }

        //Labor and Supplier Costs Report Factory
        public class LaborAndSupplierCostsReportFactory : IDirectoryReportAbstractFactory
        {
            public IRelatedClassReport CreateInstanceOf(string concreteClassName)
            {
                return concreteClassName switch
                {
                    "LaborCosts" => new LaborCostsReport(),
                    "SupplierPerformance" => new SupplierPerformanceReport(),
                    "CostBenchmarking" => new CostBenchmarkingReport(),
                    _ => throw new ArgumentException("Invalid report type"),
                };
            }
        }

        //Maintenance and Equipment Costs Report Factory
        public class MaintenanceAndEquipmentCostsReportFactory : IDirectoryReportAbstractFactory
        {
            public IRelatedClassReport CreateInstanceOf(string concreteClassName)
            {
                return concreteClassName switch
                {
                    "EquipmentTotalCostOfOwnership" => new EquipmentTotalCostOfOwnershipReport(),
                    "PreventiveAndCorrectiveMaintenanceCosts" => new PreventiveAndCorrectiveMaintenanceCostsReport(),
                    "ReprocessingAndScrapCosts" => new ReprocessingAndScrapCostsReport(),
                    _ => throw new ArgumentException("Invalid report type"),
                };
            }
        }

        //Energy and Environmental Costs Report Factory
        public class EnergyAndEnvironmentalCostsReportFactory : IDirectoryReportAbstractFactory
        {
            public IRelatedClassReport CreateInstanceOf(string concreteClassName)
            {
                return concreteClassName switch
                {
                    "EnergyCosts" => new EnergyCostsReport(),
                    "EnvironmentalCostsImpact" => new EnvironmentalCostsImpactReport(),
                    _ => throw new ArgumentException("Invalid report type"),
                };
            }
        }

        //Warranty and Repair Costs Report Factory
        public class WarrantyAndRepairCostsReportFactory : IDirectoryReportAbstractFactory
        {
            public IRelatedClassReport CreateInstanceOf(string concreteClassName)
            {
                return concreteClassName switch
                {
                    "WarrantyAndRepairCosts" => new WarrantyAndRepairCostsReport(),
                    _ => throw new ArgumentException("Invalid report type"),
                };
            }
        }

        //Innovations and
        //Technologies Costs Report Factory

        public class InnovationsAndTechnologiesCostsReportFactory : IDirectoryReportAbstractFactory
        {
            public IRelatedClassReport CreateInstanceOf(string concreteClassName)
            {
                return concreteClassName switch
                {
                    "TechnologyCostBenefit" => new TechnologyCostBenefitReport(),
                    _ => throw new ArgumentException("Invalid report type"),
                };
            }
        }
        #endregion

        static void Main(string[] args)
        {
            /// Simulate user requests
            var userRequests = new List<(string family, string concreteClassName)>
                {
                ("OperationalAndAdministrativeCosts", "FixedAndVariableCosts"),
                ("OperationalAndAdministrativeCosts", "OperationalExpenses"),
                ("ProductionAndMaterialsCosts", "RawMaterialsCosts"),
                ("ProductionAndMaterialsCosts", "VehicleCost"),
                ("LogisticsAndTransportationCosts", "LogisticsAndTransportationCosts"),
                ("LaborAndSupplierCosts", "LaborCosts")
                };

            // Dictionary to map family names to their respective factories
            var factories = new Dictionary<string, IDirectoryReportAbstractFactory>
                {
                { "OperationalAndAdministrativeCosts", new OperationalAndAdministrativeCostsReportFactory() },
                { "ProductionAndMaterialsCosts", new ProductionAndMaterialsCostsReportFactory() },
                { "LogisticsAndTransportationCosts", new LogisticsAndTransportationCostsReportFactory() },
                { "LaborAndSupplierCosts", new LaborAndSupplierCostsReportFactory() },
                { "MaintenanceAndEquipmentCosts", new MaintenanceAndEquipmentCostsReportFactory() },
                { "EnergyAndEnvironmentalCosts", new EnergyAndEnvironmentalCostsReportFactory() },
                { "WarrantyAndRepairCosts", new WarrantyAndRepairCostsReportFactory() },
                { "InnovationsAndTechnologiesCosts", new InnovationsAndTechnologiesCostsReportFactory() }
                };

            // Generate reports based on user requests
            foreach (var request in userRequests)
            {
                if (factories.TryGetValue(request.family, out var factory))
                {
                    var report = factory.CreateInstanceOf(request.concreteClassName);
                    report.GenerateReport();
                }
                else
                {
                    Console.WriteLine($"Factory for family {request.family} not found.");
                }
            }
        }
    }
}
