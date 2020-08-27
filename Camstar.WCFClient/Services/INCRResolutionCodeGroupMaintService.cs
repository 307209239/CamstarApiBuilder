// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRResolutionCodeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRResolutionCodeGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_LoadESigDetails_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Parameters parameters,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaintMethod[] methods,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRResolutionCodeGroupMaint nCRResolutionCodeGroupMaint,
      NCRResolutionCodeGroupMaint_Request request,
      out NCRResolutionCodeGroupMaint_Result result);
  }
}
