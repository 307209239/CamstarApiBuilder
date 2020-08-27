// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICarrierStatusCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICarrierStatusCodeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_LoadESigDetails_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CarrierStatusCodeMaintMethod[] methods,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result);
  }
}
