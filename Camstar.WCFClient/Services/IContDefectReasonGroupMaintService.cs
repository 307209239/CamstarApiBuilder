// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContDefectReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContDefectReasonGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_LoadESigDetails_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Parameters parameters,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContDefectReasonGroupMaintMethod[] methods,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContDefectReasonGroupMaint contDefectReasonGroupMaint,
      ContDefectReasonGroupMaint_Request request,
      out ContDefectReasonGroupMaint_Result result);
  }
}
