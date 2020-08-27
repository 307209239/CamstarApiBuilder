// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IActionRuleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IActionRuleMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_LoadESigDetails_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ActionRuleMaintMethod[] methods,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result);
  }
}
