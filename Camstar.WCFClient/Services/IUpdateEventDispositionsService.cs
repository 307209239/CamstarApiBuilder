// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateEventDispositionsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateEventDispositionsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Parameters parameters,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateEventDispositionsMethod[] methods,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateEventDispositions updateEventDispositions,
      UpdateEventDispositions_Request request,
      out UpdateEventDispositions_Result result);
  }
}
