// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPriorityLevelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPriorityLevelMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_LoadESigDetails_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Parameters parameters,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PriorityLevelMaintMethod[] methods,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PriorityLevelMaint priorityLevelMaint,
      PriorityLevelMaint_Request request,
      out PriorityLevelMaint_Result result);
  }
}
