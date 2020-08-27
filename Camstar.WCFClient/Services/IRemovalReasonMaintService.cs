// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRemovalReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRemovalReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_LoadESigDetails_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Parameters parameters,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RemovalReasonMaintMethod[] methods,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RemovalReasonMaint removalReasonMaint,
      RemovalReasonMaint_Request request,
      out RemovalReasonMaint_Result result);
  }
}
