// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRemoveDifferenceReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRemoveDifferenceReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_LoadESigDetails_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Parameters parameters,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RemoveDifferenceReasonMaintMethod[] methods,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RemoveDifferenceReasonMaint removeDifferenceReasonMaint,
      RemoveDifferenceReasonMaint_Request request,
      out RemoveDifferenceReasonMaint_Result result);
  }
}
