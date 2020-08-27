// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ILossReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ILossReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_LoadESigDetails_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      LossReasonMaintMethod[] methods,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result);
  }
}
