// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DataTransportMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DataTransportMaintService : NamedDataObjectMaintBase
  {
    public DataTransportMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDataTransportMaintService), userProfile);
    }

    public ResultStatus Delete(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataTransportMaintService) this._Channel).Delete(this._UserProfile, dataTransportMaint, parameters, request, out result) : this.AddMethod((Method) new DataTransportMaintMethod(dataTransportMaint, DataTransportMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DataTransportMaint) null, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus Delete(DataTransportMaint dataTransportMaint)
    {
      return this.Delete(dataTransportMaint, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus Delete(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      return this.Delete(dataTransportMaint, (DataTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataTransportMaintService) this._Channel).Freeze(this._UserProfile, dataTransportMaint, parameters, request, out result) : this.AddMethod((Method) new DataTransportMaintMethod(dataTransportMaint, DataTransportMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DataTransportMaint) null, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus Freeze(DataTransportMaint dataTransportMaint)
    {
      return this.Freeze(dataTransportMaint, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus Freeze(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      return this.Freeze(dataTransportMaint, (DataTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataTransportMaintService) this._Channel).GetWIPMsgs(this._UserProfile, dataTransportMaint, parameters, request, out result) : this.AddMethod((Method) new DataTransportMaintMethod(dataTransportMaint, DataTransportMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DataTransportMaint) null, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(DataTransportMaint dataTransportMaint)
    {
      return this.GetWIPMsgs(dataTransportMaint, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      return this.GetWIPMsgs(dataTransportMaint, (DataTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataTransportMaintService) this._Channel).Load(this._UserProfile, dataTransportMaint, parameters, request, out result) : this.AddMethod((Method) new DataTransportMaintMethod(dataTransportMaint, DataTransportMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DataTransportMaint) null, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus Load(DataTransportMaint dataTransportMaint)
    {
      return this.Load(dataTransportMaint, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus Load(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      return this.Load(dataTransportMaint, (DataTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_LoadESigDetails_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataTransportMaintService) this._Channel).LoadESigDetails(this._UserProfile, dataTransportMaint, parameters, request, out result) : this.AddMethod((Method) new DataTransportMaintMethod(dataTransportMaint, DataTransportMaintMethods.LoadESigDetails, (DataTransportMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DataTransportMaint) null, (DataTransportMaint_LoadESigDetails_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus LoadESigDetails(DataTransportMaint dataTransportMaint)
    {
      return this.LoadESigDetails(dataTransportMaint, (DataTransportMaint_LoadESigDetails_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      return this.LoadESigDetails(dataTransportMaint, (DataTransportMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataTransportMaintService) this._Channel).New(this._UserProfile, dataTransportMaint, parameters, request, out result) : this.AddMethod((Method) new DataTransportMaintMethod(dataTransportMaint, DataTransportMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DataTransportMaint) null, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus New(DataTransportMaint dataTransportMaint)
    {
      return this.New(dataTransportMaint, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus New(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      return this.New(dataTransportMaint, (DataTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataTransportMaintService) this._Channel).NewCopy(this._UserProfile, dataTransportMaint, parameters, request, out result) : this.AddMethod((Method) new DataTransportMaintMethod(dataTransportMaint, DataTransportMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DataTransportMaint) null, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus NewCopy(DataTransportMaint dataTransportMaint)
    {
      return this.NewCopy(dataTransportMaint, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus NewCopy(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      return this.NewCopy(dataTransportMaint, (DataTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataTransportMaintService) this._Channel).SaveAs(this._UserProfile, dataTransportMaint, parameters, request, out result) : this.AddMethod((Method) new DataTransportMaintMethod(dataTransportMaint, DataTransportMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DataTransportMaint) null, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus SaveAs(DataTransportMaint dataTransportMaint)
    {
      return this.SaveAs(dataTransportMaint, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus SaveAs(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      return this.SaveAs(dataTransportMaint, (DataTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Parameters parameters,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataTransportMaintService) this._Channel).UnFreeze(this._UserProfile, dataTransportMaint, parameters, request, out result) : this.AddMethod((Method) new DataTransportMaintMethod(dataTransportMaint, DataTransportMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) dataTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DataTransportMaint) null, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus UnFreeze(DataTransportMaint dataTransportMaint)
    {
      return this.UnFreeze(dataTransportMaint, (DataTransportMaint_Parameters) null, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DataTransportMaint dataTransportMaint,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      return this.UnFreeze(dataTransportMaint, (DataTransportMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject dataTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataTransportMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DataTransportMaint) dataTransportMaint, (DataTransportMaint_Parameters) parameters, (DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject dataTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataTransportMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DataTransportMaint) dataTransportMaint, (DataTransportMaint_Parameters) parameters, (DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject dataTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataTransportMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DataTransportMaint) dataTransportMaint, (DataTransportMaint_LoadESigDetails_Parameters) parameters, (DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject dataTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataTransportMaint_Result result1;
        ResultStatus resultStatus = this.New((DataTransportMaint) dataTransportMaint, (DataTransportMaint_Parameters) parameters, (DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject dataTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataTransportMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DataTransportMaint) dataTransportMaint, (DataTransportMaint_Parameters) parameters, (DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject dataTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataTransportMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DataTransportMaint) dataTransportMaint, (DataTransportMaint_Parameters) parameters, (DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject dataTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataTransportMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DataTransportMaint) dataTransportMaint, (DataTransportMaint_Parameters) parameters, (DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject dataTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataTransportMaint_Result result1;
        ResultStatus resultStatus = this.Load((DataTransportMaint) dataTransportMaint, (DataTransportMaint_Parameters) parameters, (DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject dataTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataTransportMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DataTransportMaint) dataTransportMaint, (DataTransportMaint_Parameters) parameters, (DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      try
      {
        DataTransportMaintMethod[] methods = new DataTransportMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDataTransportMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DataTransportMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DataTransportMaint cdo,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      try
      {
        return ((IDataTransportMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DataTransportMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DataTransportMaint) cdo, (DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      return this.GetEnvironment((DataTransportMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DataTransportMaint cdo,
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      result = (DataTransportMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataTransportMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DataTransportMaintMethod(cdo, DataTransportMaintMethods.ExecuteTransaction, (DataTransportMaint_Parameters) null));
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
        DataTransportMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DataTransportMaint) cdo, (DataTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DataTransportMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DataTransportMaint_Request) null, out DataTransportMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DataTransportMaint_Request request,
      out DataTransportMaint_Result result)
    {
      return this.ExecuteTransaction((DataTransportMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DataTransportMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DataTransportMaintMethod(cdo, DataTransportMaintMethods.AddDataTransaction, (DataTransportMaint_Parameters) null));
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
        return this.AddDataTransaction((DataTransportMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
