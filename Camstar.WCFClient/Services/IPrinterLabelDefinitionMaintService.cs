// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPrinterLabelDefinitionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPrinterLabelDefinitionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_LoadESigDetails_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PrinterLabelDefinitionMaintMethod[] methods,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result);
  }
}
