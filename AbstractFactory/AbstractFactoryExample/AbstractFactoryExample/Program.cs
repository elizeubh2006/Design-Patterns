namespace AbstractFactoryExample
{
    internal class Program
    {

        //Define the Abstract Product Interface
        public interface IReport
        {
            void GenerateReport();
        }

        #region Classes with all sort of reports
        //Implement Concrete Products for Each Family
        //Operational and Administrative Costs Reports
        public class FixedAndVariableCostsReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Fixed and Variable Costs Report...");
            }
        }

        public class OperationalExpensesReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Operational Expenses Report...");
            }
        }

        public class AdministrativeExpensesReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Administrative Expenses Report...");
            }
        }

        public class BudgetDeviationAnalysisReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Budget Deviation Analysis Report...");
            }
        }

        public class CostCenterAnalysisReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Cost Center Analysis Report...");
            }
        }

        //Production and Materials Costs Reports
        public class RawMaterialsCostsReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Raw Materials Costs Report...");
            }
        }

        public class ProductionEfficiencyReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Production Efficiency Report...");
            }
        }

        public class VehicleCostReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Vehicle Cost Report...");
            }
        }

        public class ComponentCostReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Component Cost Report...");
            }
        }

        public class WasteReductionReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Waste Reduction Report...");
            }
        }

        public class EconomiesOfScaleReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Economies of Scale Report...");
            }
        }

        //  Logistics and Transportation Costs Reports
        public class LogisticsAndTransportationCostsReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Logistics and Transportation Costs Report...");
            }
        }

        public class InventoryAndStorageCostsReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Inventory and Storage Costs Report...");
            }
        }

        public class JustInTimeSupplyAnalysisReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Just-in-Time Supply Analysis Report...");
            }
        }

        //Labor and Supplier Costs Reports
        public class LaborCostsReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Labor Costs Report...");
            }
        }

        public class SupplierPerformanceReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Supplier Performance Report...");
            }
        }

        public class CostBenchmarkingReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Cost Benchmarking Report...");
            }
        }

        //Maintenance and Equipment Costs Reports
        public class EquipmentTotalCostOfOwnershipReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Equipment Total Cost of Ownership Report...");
            }
        }

        public class PreventiveAndCorrectiveMaintenanceCostsReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Preventive and Corrective Maintenance Costs Report...");
            }
        }

        public class ReprocessingAndScrapCostsReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Reprocessing and Scrap Costs Report...");
            }
        }

        //Energy and Environmental Costs Reports
        public class EnergyCostsReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Energy Costs Report...");
            }
        }

        public class EnvironmentalCostsImpactReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Environmental Costs Impact Report...");
            }
        }

        //Warranty and Repair Costs Reports
        public class WarrantyAndRepairCostsReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Warranty and Repair Costs Report...");
            }
        }

        //Innovations and Technologies Costs Reports
        public class TechnologyCostBenefitReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Technology Cost-Benefit Report...");
            }
        }

        //Product and Profitability Costs Reports
        public class ProductProfitabilityAnalysisReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Product Profitability Analysis Report...");
            }
        }

        public class ImportedInputsCostsAnalysisReport : IReport
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating Imported Inputs Costs Analysis Report...");
            }
        }

        public class FutureCostsProjectionsReport : IReport
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
            IReport CreateReport(string reportType);
        }

        #region All Factories
        //Implement Concrete Factories for Each Family
        //Operational and Administrative Costs Report Factory
        public class OperationalAndAdministrativeCostsReportFactory : IDirectoryReportAbstractFactory
        {
            public IReport CreateReport(string reportType)
            {
                return reportType switch
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
            public IReport CreateReport(string reportType)
            {
                return reportType switch
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
            public IReport CreateReport(string reportType)
            {
                return reportType switch
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
            public IReport CreateReport(string reportType)
            {
                return reportType switch
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
            public IReport CreateReport(string reportType)
            {
                return reportType switch
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
            public IReport CreateReport(string reportType)
            {
                return reportType switch
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
            public IReport CreateReport(string reportType)
            {
                return reportType switch
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
            public IReport CreateReport(string reportType)
            {
                return reportType switch
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
            var userRequests = new List<(string family, string reportType)>
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
                    var report = factory.CreateReport(request.reportType);
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
