// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRevisionedObjectMaintBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  public interface IRevisionedObjectMaintBase : IMaintenanceBase
  {
    [OperationContract]
    ResultStatus DeleteAllRevisions(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      DCObject revisionedObjectMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(DCObject revisionedObjectMaint);

    [OperationContract]
    ResultStatus DeleteAllRevisions();

    [OperationContract]
    ResultStatus NewRev(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus NewRev(
      DCObject revisionedObjectMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus NewRev(DCObject revisionedObjectMaint);

    [OperationContract]
    ResultStatus NewRev();

    [OperationContract]
    ResultStatus NewRevCopy(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      DCObject revisionedObjectMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus NewRevCopy(DCObject revisionedObjectMaint);

    [OperationContract]
    ResultStatus NewRevCopy();

    [OperationContract]
    ResultStatus SaveAsRev(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      DCObject revisionedObjectMaint,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus SaveAsRev(DCObject revisionedObjectMaint);

    [OperationContract]
    ResultStatus SaveAsRev();
  }
}
