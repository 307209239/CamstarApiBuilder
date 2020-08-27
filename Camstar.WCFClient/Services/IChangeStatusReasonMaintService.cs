// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeStatusReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeStatusReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_LoadESigDetails_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeStatusReasonMaintMethod[] methods,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result);
  }
}
