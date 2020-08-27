// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResStatusReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResStatusReasonGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_LoadESigDetails_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Parameters parameters,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResStatusReasonGroupMaintMethod[] methods,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResStatusReasonGroupMaint resStatusReasonGroupMaint,
      ResStatusReasonGroupMaint_Request request,
      out ResStatusReasonGroupMaint_Result result);
  }
}
