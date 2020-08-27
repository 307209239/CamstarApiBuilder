// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBuyReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBuyReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_LoadESigDetails_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BuyReasonMaintMethod[] methods,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result);
  }
}
