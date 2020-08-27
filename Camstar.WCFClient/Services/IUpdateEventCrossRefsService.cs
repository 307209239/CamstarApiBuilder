// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateEventCrossRefsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateEventCrossRefsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Parameters parameters,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateEventCrossRefsMethod[] methods,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateEventCrossRefs updateEventCrossRefs,
      UpdateEventCrossRefs_Request request,
      out UpdateEventCrossRefs_Result result);
  }
}
