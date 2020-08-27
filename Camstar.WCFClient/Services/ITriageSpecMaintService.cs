// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITriageSpecMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITriageSpecMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_LoadESigDetails_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TriageSpecMaintMethod[] methods,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result);
  }
}
