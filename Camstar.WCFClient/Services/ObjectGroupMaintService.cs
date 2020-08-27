// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ObjectGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ObjectGroupMaintService : NamedDataObjectMaintBase
  {
    public ObjectGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IObjectGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IObjectGroupMaintService) this._Channel).Delete(this._UserProfile, objectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ObjectGroupMaintMethod(objectGroupMaint, ObjectGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ObjectGroupMaint) null, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus Delete(ObjectGroupMaint objectGroupMaint)
    {
      return this.Delete(objectGroupMaint, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      return this.Delete(objectGroupMaint, (ObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IObjectGroupMaintService) this._Channel).Freeze(this._UserProfile, objectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ObjectGroupMaintMethod(objectGroupMaint, ObjectGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ObjectGroupMaint) null, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus Freeze(ObjectGroupMaint objectGroupMaint)
    {
      return this.Freeze(objectGroupMaint, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      return this.Freeze(objectGroupMaint, (ObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IObjectGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, objectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ObjectGroupMaintMethod(objectGroupMaint, ObjectGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ObjectGroupMaint) null, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ObjectGroupMaint objectGroupMaint)
    {
      return this.GetWIPMsgs(objectGroupMaint, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      return this.GetWIPMsgs(objectGroupMaint, (ObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IObjectGroupMaintService) this._Channel).Load(this._UserProfile, objectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ObjectGroupMaintMethod(objectGroupMaint, ObjectGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ObjectGroupMaint) null, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus Load(ObjectGroupMaint objectGroupMaint)
    {
      return this.Load(objectGroupMaint, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus Load(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      return this.Load(objectGroupMaint, (ObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_LoadESigDetails_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IObjectGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, objectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ObjectGroupMaintMethod(objectGroupMaint, ObjectGroupMaintMethods.LoadESigDetails, (ObjectGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ObjectGroupMaint) null, (ObjectGroupMaint_LoadESigDetails_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ObjectGroupMaint objectGroupMaint)
    {
      return this.LoadESigDetails(objectGroupMaint, (ObjectGroupMaint_LoadESigDetails_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      return this.LoadESigDetails(objectGroupMaint, (ObjectGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IObjectGroupMaintService) this._Channel).New(this._UserProfile, objectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ObjectGroupMaintMethod(objectGroupMaint, ObjectGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ObjectGroupMaint) null, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus New(ObjectGroupMaint objectGroupMaint)
    {
      return this.New(objectGroupMaint, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus New(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      return this.New(objectGroupMaint, (ObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IObjectGroupMaintService) this._Channel).NewCopy(this._UserProfile, objectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ObjectGroupMaintMethod(objectGroupMaint, ObjectGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ObjectGroupMaint) null, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus NewCopy(ObjectGroupMaint objectGroupMaint)
    {
      return this.NewCopy(objectGroupMaint, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      return this.NewCopy(objectGroupMaint, (ObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IObjectGroupMaintService) this._Channel).SaveAs(this._UserProfile, objectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ObjectGroupMaintMethod(objectGroupMaint, ObjectGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ObjectGroupMaint) null, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus SaveAs(ObjectGroupMaint objectGroupMaint)
    {
      return this.SaveAs(objectGroupMaint, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      return this.SaveAs(objectGroupMaint, (ObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IObjectGroupMaintService) this._Channel).UnFreeze(this._UserProfile, objectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ObjectGroupMaintMethod(objectGroupMaint, ObjectGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) objectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ObjectGroupMaint) null, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(ObjectGroupMaint objectGroupMaint)
    {
      return this.UnFreeze(objectGroupMaint, (ObjectGroupMaint_Parameters) null, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      return this.UnFreeze(objectGroupMaint, (ObjectGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject objectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ObjectGroupMaint) objectGroupMaint, (ObjectGroupMaint_Parameters) parameters, (ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject objectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ObjectGroupMaint) objectGroupMaint, (ObjectGroupMaint_Parameters) parameters, (ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject objectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ObjectGroupMaint) objectGroupMaint, (ObjectGroupMaint_LoadESigDetails_Parameters) parameters, (ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject objectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((ObjectGroupMaint) objectGroupMaint, (ObjectGroupMaint_Parameters) parameters, (ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject objectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ObjectGroupMaint) objectGroupMaint, (ObjectGroupMaint_Parameters) parameters, (ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject objectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ObjectGroupMaint) objectGroupMaint, (ObjectGroupMaint_Parameters) parameters, (ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject objectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ObjectGroupMaint) objectGroupMaint, (ObjectGroupMaint_Parameters) parameters, (ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject objectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((ObjectGroupMaint) objectGroupMaint, (ObjectGroupMaint_Parameters) parameters, (ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject objectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ObjectGroupMaint) objectGroupMaint, (ObjectGroupMaint_Parameters) parameters, (ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      try
      {
        ObjectGroupMaintMethod[] methods = new ObjectGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IObjectGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ObjectGroupMaint cdo,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      try
      {
        return ((IObjectGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ObjectGroupMaint) cdo, (ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      return this.GetEnvironment((ObjectGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ObjectGroupMaint cdo,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      result = (ObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IObjectGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ObjectGroupMaintMethod(cdo, ObjectGroupMaintMethods.ExecuteTransaction, (ObjectGroupMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ObjectGroupMaint) cdo, (ObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ObjectGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ObjectGroupMaint_Request) null, out ObjectGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result)
    {
      return this.ExecuteTransaction((ObjectGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ObjectGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ObjectGroupMaintMethod(cdo, ObjectGroupMaintMethods.AddDataTransaction, (ObjectGroupMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ObjectGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
