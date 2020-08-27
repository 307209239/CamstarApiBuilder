// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPriorityCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPriorityCodeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_LoadESigDetails_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Parameters parameters,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PriorityCodeMaintMethod[] methods,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PriorityCodeMaint priorityCodeMaint,
      PriorityCodeMaint_Request request,
      out PriorityCodeMaint_Result result);
  }
}
