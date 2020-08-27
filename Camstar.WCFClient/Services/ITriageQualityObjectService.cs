// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITriageQualityObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITriageQualityObjectService
  {
    [OperationContract]
    ResultStatus AssignChecklist(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus AssignProcessModel(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus GetTriageSpecDetail(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus SetEscalationDate(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus SetTriageComplete(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus ValidateCategoryTransition(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_ValidateCategoryTransition_Parameters parameters,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TriageQualityObjectMethod[] methods,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TriageQualityObject triageQualityObject,
      TriageQualityObject_Request request,
      out TriageQualityObject_Result result);
  }
}
