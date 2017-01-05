﻿using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace WebApiToTypeScript.Config
{
    public class Config
    {
        public string WebApiModuleFileName { get; set; }

        public bool GenerateEndpoints { get; set; }
            = false;

        public string EndpointsOutputDirectory { get; set; }
            = "Endpoints";

        public bool EndpointsSupportCaching { get; set; }
            = true;

        public string EndpointsFileName { get; set; }
            = "Endpoints.ts";

        public string EndpointsNamespace { get; set; }
            = "Endpoints";

        public bool GenerateService { get; set; }
            = false;

        public string ServiceOutputDirectory { get; set; }
            = "Endpoints";

        public string ServiceFileName { get; set; }
            = "Service.ts";

        public string ServiceNamespace { get; set; }
            = "Endpoints";

        public string ServiceName { get; set; }
            = "AngularEndpointsService";

        public bool GenerateEnums { get; set; }
            = true;

        public bool GenerateEnumDescriptions { get; set; }
            = false;

        public string EnumsOutputDirectory { get; set; }
            = "Enums";

        public string EnumsFileName { get; set; }
            = "Enums.ts";

        public string EnumsNamespace { get; set; }
            = "Enums";

        public bool GenerateInterfaces { get; set; }
            = true;

        public string InterfacesOutputDirectory { get; set; }
            = "Interfaces";

        public string InterfacesFileName { get; set; }
            = "Interfaces.ts";

        public string InterfacesNamespace { get; set; }
            = "Interfaces";

        public bool InterfaceMembersInCamelCase { get; set; }
            = true;

        public List<InterfaceMatch> InterfaceMatches { get; set; }
            = new List<InterfaceMatch>();

        public bool GenerateViews { get; set; }
            = false;

        public List<ViewConfig> ViewConfigs { get; set; }
            = new List<ViewConfig>();

        public string ViewsPattern { get; set; }
            = ".view.";

        public string ViewsOutputDirectory { get; set; }
            = "Views";

        public bool UseViewsGroupingNamespace { get; set; }
            = true;

        public bool GenerateResources { get; set; }
            = false;

        public List<ResourceConfig> ResourceConfigs { get; set; }
            = new List<ResourceConfig>();

        public string ResourcesNamespace { get; set; }
            = "Resources";

        public string ResourcesOutputDirectory { get; set; }
            = "Resources";

        public bool ScanOtherModules { get; set; }
            = true;

        public bool WriteNamespaceAsModule { get; set; }
            = false;

        public string NamespaceOrModuleName
            => WriteNamespaceAsModule ? "module" : "namespace";

        public List<TypeMapping> TypeMappings { get; set; }
            = new List<TypeMapping>();
    }
}