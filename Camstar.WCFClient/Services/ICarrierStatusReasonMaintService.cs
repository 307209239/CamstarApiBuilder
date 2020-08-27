// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICarrierStatusReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICarrierStatusReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_LoadESigDetails_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CarrierStatusReasonMaintMethod[] methods,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result);
  }
}
