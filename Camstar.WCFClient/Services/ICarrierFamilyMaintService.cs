// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICarrierFamilyMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICarrierFamilyMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_LoadESigDetails_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CarrierFamilyMaintMethod[] methods,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result);
  }
}
