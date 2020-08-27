// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IScheduledBusinessRuleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IScheduledBusinessRuleMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus Hold(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_LoadESigDetails_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus Release(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus Validate(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ScheduledBusinessRuleMaintMethod[] methods,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result);
  }
}
