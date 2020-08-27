// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INumberingRuleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INumberingRuleMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_LoadESigDetails_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus ResetLastAssignedSequence(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Parameters parameters,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NumberingRuleMaintMethod[] methods,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NumberingRuleMaint numberingRuleMaint,
      NumberingRuleMaint_Request request,
      out NumberingRuleMaint_Result result);
  }
}
