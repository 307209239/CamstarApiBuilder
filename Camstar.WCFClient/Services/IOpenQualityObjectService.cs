// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IOpenQualityObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IOpenQualityObjectService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      OpenQualityObjectMethod[] methods,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      OpenQualityObject openQualityObject,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      OpenQualityObject openQualityObject,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result);
  }
}
