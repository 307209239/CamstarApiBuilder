// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReprocessActivityService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReprocessActivityService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Parameters parameters,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReprocessActivityMethod[] methods,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReprocessActivity reprocessActivity,
      ReprocessActivity_Request request,
      out ReprocessActivity_Result result);
  }
}
