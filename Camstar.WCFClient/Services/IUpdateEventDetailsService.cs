// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateEventDetailsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateEventDetailsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus GetDetails(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus ModifyDetails(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Parameters parameters,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateEventDetailsMethod[] methods,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateEventDetails updateEventDetails,
      UpdateEventDetails_Request request,
      out UpdateEventDetails_Result result);
  }
}
