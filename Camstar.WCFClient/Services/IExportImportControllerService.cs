// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IExportImportControllerService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IExportImportControllerService
  {
    [OperationContract]
    ResultStatus DeleteExportFile(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus DeleteImportContent(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus GenerateExportFile(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus GetExportFile(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus RestartProcess(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus ResumeProcess(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus SetImportFile(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus StopProcess(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Parameters parameters,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ExportImportControllerMethod[] methods,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ExportImportController exportImportController,
      ExportImportController_Request request,
      out ExportImportController_Result result);
  }
}
