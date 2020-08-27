// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangePackagePriorityMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangePackagePriorityMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_LoadESigDetails_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangePackagePriorityMaintMethod[] methods,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result);
  }
}
