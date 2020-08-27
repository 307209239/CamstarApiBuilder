// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ILocalReworkReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ILocalReworkReasonGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_LoadESigDetails_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Parameters parameters,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      LocalReworkReasonGroupMaintMethod[] methods,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      LocalReworkReasonGroupMaint localReworkReasonGroupMaint,
      LocalReworkReasonGroupMaint_Request request,
      out LocalReworkReasonGroupMaint_Result result);
  }
}
