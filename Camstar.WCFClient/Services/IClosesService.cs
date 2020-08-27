// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IClosesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IClosesService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Closes closes,
      Closes_LoadESigDetails_Parameters parameters,
      Closes_Request request,
      out Closes_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ClosesMethod[] methods,
      Closes_Request request,
      out Closes_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Closes closes,
      Closes_Request request,
      out Closes_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Closes closes,
      Closes_Request request,
      out Closes_Result result);
  }
}
