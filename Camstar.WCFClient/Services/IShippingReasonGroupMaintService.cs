// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IShippingReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IShippingReasonGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_LoadESigDetails_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Parameters parameters,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ShippingReasonGroupMaintMethod[] methods,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ShippingReasonGroupMaint shippingReasonGroupMaint,
      ShippingReasonGroupMaint_Request request,
      out ShippingReasonGroupMaint_Result result);
  }
}
