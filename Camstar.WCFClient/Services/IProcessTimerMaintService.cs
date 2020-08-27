// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProcessTimerMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProcessTimerMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_LoadESigDetails_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus ValidateMaxTimeDtl(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus ValidateMinTimeDtl(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus ValidateProcessTime(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus ValidateTime(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Parameters parameters,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProcessTimerMaintMethod[] methods,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProcessTimerMaint processTimerMaint,
      ProcessTimerMaint_Request request,
      out ProcessTimerMaint_Result result);
  }
}
