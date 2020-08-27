// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IActivityDispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IActivityDispositionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadDispositions(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_LoadESigDetails_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadTemplate(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Parameters parameters,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ActivityDispositionMaintMethod[] methods,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ActivityDispositionMaint activityDispositionMaint,
      ActivityDispositionMaint_Request request,
      out ActivityDispositionMaint_Result result);
  }
}
