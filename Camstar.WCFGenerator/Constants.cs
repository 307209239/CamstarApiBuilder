// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Constants
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

namespace Camstar.WCF.Generator
{
  internal class Constants
  {
    public class File
    {
      public static string DllFileExt = ".dll";
      public static string WebConfig = "Web.config";
      public static string AppConfig = "App.config";
    }

    public class ConfigSection
    {
      public const string Query = "Query";
      public const string DirectAccess = "DirectAccess";
      public const string Authentication = "Authentication";
      public const string Label = "Label";
    }

    public class Services
    {
      public const string UserProfile = "UserProfile";
      public const string DirectXMLSubmitMethod = "Submit";
      public const string QueryExecuteMethod = "Execute";
      public const string QueryExecuteAdHocMethod = "ExecuteAdHoc";
      public const string OnThrowExceptionMethod = "OnThrowException";
      public const string NoMethod = "NoMethod";
      public const string ChannelFieldName = "_Channel";
      public const string UserProfileFieldName = "_UserProfile";
      public const string IsTransactionOpenedFieldName = "_IsTransactionOpened";
    }

    public class GeneralAssemblyInfo
    {
      public const string Title = "WCF Generated Assembly";
      public const string ProductName = "Camstar Enterprise Platform";
      public const string CompanyName = "Siemens Product Lifecycle Management Software Inc.";
      public const string Copyright = "© 2017 Siemens Product Lifecycle Management Software Inc.";
      public const string Version = "1.0.0.0";
    }
  }
}
