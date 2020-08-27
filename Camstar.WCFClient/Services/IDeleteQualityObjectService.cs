// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDeleteQualityObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDeleteQualityObjectService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);

    [OperationContract]
    ResultStatus DeleteCrossReference(
      UserProfile userProfile,
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_DeleteCrossReference_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Parameters parameters,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DeleteQualityObjectMethod[] methods,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DeleteQualityObject deleteQualityObject,
      DeleteQualityObject_Request request,
      out DeleteQualityObject_Result result);
  }
}
