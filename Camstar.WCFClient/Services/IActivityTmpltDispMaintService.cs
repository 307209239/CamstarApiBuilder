// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IActivityTmpltDispMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IActivityTmpltDispMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_LoadESigDetails_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Parameters parameters,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ActivityTmpltDispMaintMethod[] methods,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ActivityTmpltDispMaint activityTmpltDispMaint,
      ActivityTmpltDispMaint_Request request,
      out ActivityTmpltDispMaint_Result result);
  }
}
