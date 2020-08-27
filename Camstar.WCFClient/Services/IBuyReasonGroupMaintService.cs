// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBuyReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBuyReasonGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_LoadESigDetails_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BuyReasonGroupMaintMethod[] methods,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result);
  }
}
