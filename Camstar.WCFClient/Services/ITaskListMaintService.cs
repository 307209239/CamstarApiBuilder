// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITaskListMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITaskListMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_LoadESigDetails_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Parameters parameters,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TaskListMaintMethod[] methods,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TaskListMaint taskListMaint,
      TaskListMaint_Request request,
      out TaskListMaint_Result result);
  }
}
