// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReworkReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReworkReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_LoadESigDetails_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Parameters parameters,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReworkReasonMaintMethod[] methods,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReworkReasonMaint reworkReasonMaint,
      ReworkReasonMaint_Request request,
      out ReworkReasonMaint_Result result);
  }
}
