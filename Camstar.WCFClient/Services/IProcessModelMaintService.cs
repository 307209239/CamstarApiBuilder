// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProcessModelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProcessModelMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_LoadESigDetails_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus LoadTemplate(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus ValidateStageOnAdd(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus ValidateStageOnDelete(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Parameters parameters,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProcessModelMaintMethod[] methods,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProcessModelMaint processModelMaint,
      ProcessModelMaint_Request request,
      out ProcessModelMaint_Result result);
  }
}
