// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISwitchingRuleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISwitchingRuleMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_LoadESigDetails_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SwitchingRuleMaintMethod[] methods,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result);
  }
}
