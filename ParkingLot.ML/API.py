
from fastapi import FastAPI, File, UploadFile
from fastapi.responses import JSONResponse
from Model import Predict
import uvicorn

app = FastAPI()

@app.post("/api/plate/detect")
async def Detect(file: UploadFile = File(...)):
    try:

  

        return {"plate": file.filename}
    
    except Exception as e:
        print(f"Error: {str(e)}")
        return JSONResponse(content={"py error": str(e)}, status_code=500)


if __name__ == "__main__":
    uvicorn.run(app, host="0.0.0.0", port=5000)

