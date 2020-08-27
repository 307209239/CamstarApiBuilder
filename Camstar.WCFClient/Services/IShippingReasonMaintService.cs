// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IShippingReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IShippingReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_LoadESigDetails_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Parameters parameters,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ShippingReasonMaintMethod[] methods,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ShippingReasonMaint shippingReasonMaint,
      ShippingReasonMaint_Request request,
      out ShippingReasonMaint_Result result);
  }
}
