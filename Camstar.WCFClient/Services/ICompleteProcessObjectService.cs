// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICompleteProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICompleteProcessObjectService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CompleteProcessObjectMethod[] methods,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result);
  }
}
