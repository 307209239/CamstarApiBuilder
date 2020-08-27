// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICloseQualityObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICloseQualityObjectService
  {
    [OperationContract]
    ResultStatus CloseMfgNCR(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus ExecuteChecklist(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus ValidateClose(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus ValidateDispositions(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Parameters parameters,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CloseQualityObjectMethod[] methods,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CloseQualityObject closeQualityObject,
      CloseQualityObject_Request request,
      out CloseQualityObject_Result result);
  }
}
