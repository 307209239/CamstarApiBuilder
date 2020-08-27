// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRFailureCodeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRFailureCodeGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_LoadESigDetails_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Parameters parameters,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRFailureCodeGroupMaintMethod[] methods,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRFailureCodeGroupMaint nCRFailureCodeGroupMaint,
      NCRFailureCodeGroupMaint_Request request,
      out NCRFailureCodeGroupMaint_Result result);
  }
}
