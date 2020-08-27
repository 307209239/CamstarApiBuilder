// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICarrierGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICarrierGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_LoadESigDetails_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CarrierGroupMaintMethod[] methods,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result);
  }
}
