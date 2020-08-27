// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReworkReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReworkReasonGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_LoadESigDetails_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Parameters parameters,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReworkReasonGroupMaintMethod[] methods,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReworkReasonGroupMaint reworkReasonGroupMaint,
      ReworkReasonGroupMaint_Request request,
      out ReworkReasonGroupMaint_Result result);
  }
}
