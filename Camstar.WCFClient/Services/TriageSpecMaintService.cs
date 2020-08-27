// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TriageSpecMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TriageSpecMaintService : NamedDataObjectMaintBase
  {
    public TriageSpecMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITriageSpecMaintService), userProfile);
    }

    public ResultStatus Delete(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageSpecMaintService) this._Channel).Delete(this._UserProfile, triageSpecMaint, parameters, request, out result) : this.AddMethod((Method) new TriageSpecMaintMethod(triageSpecMaint, TriageSpecMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((TriageSpecMaint) null, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus Delete(TriageSpecMaint triageSpecMaint)
    {
      return this.Delete(triageSpecMaint, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus Delete(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      return this.Delete(triageSpecMaint, (TriageSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageSpecMaintService) this._Channel).Freeze(this._UserProfile, triageSpecMaint, parameters, request, out result) : this.AddMethod((Method) new TriageSpecMaintMethod(triageSpecMaint, TriageSpecMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((TriageSpecMaint) null, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus Freeze(TriageSpecMaint triageSpecMaint)
    {
      return this.Freeze(triageSpecMaint, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus Freeze(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      return this.Freeze(triageSpecMaint, (TriageSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageSpecMaintService) this._Channel).GetWIPMsgs(this._UserProfile, triageSpecMaint, parameters, request, out result) : this.AddMethod((Method) new TriageSpecMaintMethod(triageSpecMaint, TriageSpecMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TriageSpecMaint) null, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(TriageSpecMaint triageSpecMaint)
    {
      return this.GetWIPMsgs(triageSpecMaint, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      return this.GetWIPMsgs(triageSpecMaint, (TriageSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageSpecMaintService) this._Channel).Load(this._UserProfile, triageSpecMaint, parameters, request, out result) : this.AddMethod((Method) new TriageSpecMaintMethod(triageSpecMaint, TriageSpecMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TriageSpecMaint) null, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus Load(TriageSpecMaint triageSpecMaint)
    {
      return this.Load(triageSpecMaint, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus Load(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      return this.Load(triageSpecMaint, (TriageSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_LoadESigDetails_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageSpecMaintService) this._Channel).LoadESigDetails(this._UserProfile, triageSpecMaint, parameters, request, out result) : this.AddMethod((Method) new TriageSpecMaintMethod(triageSpecMaint, TriageSpecMaintMethods.LoadESigDetails, (TriageSpecMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TriageSpecMaint) null, (TriageSpecMaint_LoadESigDetails_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus LoadESigDetails(TriageSpecMaint triageSpecMaint)
    {
      return this.LoadESigDetails(triageSpecMaint, (TriageSpecMaint_LoadESigDetails_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      return this.LoadESigDetails(triageSpecMaint, (TriageSpecMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageSpecMaintService) this._Channel).New(this._UserProfile, triageSpecMaint, parameters, request, out result) : this.AddMethod((Method) new TriageSpecMaintMethod(triageSpecMaint, TriageSpecMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((TriageSpecMaint) null, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus New(TriageSpecMaint triageSpecMaint)
    {
      return this.New(triageSpecMaint, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus New(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      return this.New(triageSpecMaint, (TriageSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageSpecMaintService) this._Channel).NewCopy(this._UserProfile, triageSpecMaint, parameters, request, out result) : this.AddMethod((Method) new TriageSpecMaintMethod(triageSpecMaint, TriageSpecMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((TriageSpecMaint) null, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus NewCopy(TriageSpecMaint triageSpecMaint)
    {
      return this.NewCopy(triageSpecMaint, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus NewCopy(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      return this.NewCopy(triageSpecMaint, (TriageSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageSpecMaintService) this._Channel).SaveAs(this._UserProfile, triageSpecMaint, parameters, request, out result) : this.AddMethod((Method) new TriageSpecMaintMethod(triageSpecMaint, TriageSpecMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((TriageSpecMaint) null, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus SaveAs(TriageSpecMaint triageSpecMaint)
    {
      return this.SaveAs(triageSpecMaint, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus SaveAs(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      return this.SaveAs(triageSpecMaint, (TriageSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Parameters parameters,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageSpecMaintService) this._Channel).UnFreeze(this._UserProfile, triageSpecMaint, parameters, request, out result) : this.AddMethod((Method) new TriageSpecMaintMethod(triageSpecMaint, TriageSpecMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) triageSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((TriageSpecMaint) null, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus UnFreeze(TriageSpecMaint triageSpecMaint)
    {
      return this.UnFreeze(triageSpecMaint, (TriageSpecMaint_Parameters) null, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus UnFreeze(
      TriageSpecMaint triageSpecMaint,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      return this.UnFreeze(triageSpecMaint, (TriageSpecMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject triageSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageSpecMaint_Result result1;
        ResultStatus resultStatus = this.Delete((TriageSpecMaint) triageSpecMaint, (TriageSpecMaint_Parameters) parameters, (TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject triageSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageSpecMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((TriageSpecMaint) triageSpecMaint, (TriageSpecMaint_Parameters) parameters, (TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject triageSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageSpecMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TriageSpecMaint) triageSpecMaint, (TriageSpecMaint_LoadESigDetails_Parameters) parameters, (TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject triageSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageSpecMaint_Result result1;
        ResultStatus resultStatus = this.New((TriageSpecMaint) triageSpecMaint, (TriageSpecMaint_Parameters) parameters, (TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject triageSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageSpecMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((TriageSpecMaint) triageSpecMaint, (TriageSpecMaint_Parameters) parameters, (TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject triageSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageSpecMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((TriageSpecMaint) triageSpecMaint, (TriageSpecMaint_Parameters) parameters, (TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject triageSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageSpecMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((TriageSpecMaint) triageSpecMaint, (TriageSpecMaint_Parameters) parameters, (TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject triageSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageSpecMaint_Result result1;
        ResultStatus resultStatus = this.Load((TriageSpecMaint) triageSpecMaint, (TriageSpecMaint_Parameters) parameters, (TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject triageSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TriageSpecMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TriageSpecMaint) triageSpecMaint, (TriageSpecMaint_Parameters) parameters, (TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      try
      {
        TriageSpecMaintMethod[] methods = new TriageSpecMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITriageSpecMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TriageSpecMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TriageSpecMaint cdo,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      try
      {
        return ((ITriageSpecMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TriageSpecMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((TriageSpecMaint) cdo, (TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      return this.GetEnvironment((TriageSpecMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TriageSpecMaint cdo,
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      result = (TriageSpecMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITriageSpecMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TriageSpecMaintMethod(cdo, TriageSpecMaintMethods.ExecuteTransaction, (TriageSpecMaint_Parameters) null));
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
        TriageSpecMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TriageSpecMaint) cdo, (TriageSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TriageSpecMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (TriageSpecMaint_Request) null, out TriageSpecMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TriageSpecMaint_Request request,
      out TriageSpecMaint_Result result)
    {
      return this.ExecuteTransaction((TriageSpecMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TriageSpecMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TriageSpecMaintMethod(cdo, TriageSpecMaintMethods.AddDataTransaction, (TriageSpecMaint_Parameters) null));
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
        return this.AddDataTransaction((TriageSpecMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
