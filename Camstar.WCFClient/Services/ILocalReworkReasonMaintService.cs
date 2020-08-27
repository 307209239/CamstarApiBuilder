// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ILocalReworkReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ILocalReworkReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_LoadESigDetails_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Parameters parameters,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      LocalReworkReasonMaintMethod[] methods,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      LocalReworkReasonMaint localReworkReasonMaint,
      LocalReworkReasonMaint_Request request,
      out LocalReworkReasonMaint_Result result);
  }
}
