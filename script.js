let editIndex = null; 

document.getElementById("add").addEventListener("click", function() {
    const name = document.getElementById("name").value;
    const gender = document.getElementById("gender").value;
    const age = document.getElementById("age").value;
    const email = document.getElementById("email").value;
    const province = document.getElementById("province").value;

  
    if (name && gender && age && email && province) {
        const table = document.getElementById("studentTable").getElementsByTagName('tbody')[0];

        if (editIndex === null) {
            // Add a new row
            const newRow = table.insertRow(table.rows.length);
            newRow.innerHTML = `
                <th>${table.rows.length}</th>
                <th>${name}</th>
                <th>${gender}</th>
                <th>${age}</th>
                <th>${email}</th>
                <th>${province}</th>
                <th>
                    <a href="javascript:void(0)" class="editLink">Edit</a> | 
                    <a href="javascript:void(0)" class="deleteLink">Delete</a>
                </th>
            `;
        } else {
           
            const row = table.rows[editIndex];
            row.cells[1].textContent = name;
            row.cells[2].textContent = gender;
            row.cells[3].textContent = age;
            row.cells[4].textContent = email;
            row.cells[5].textContent = province;

           
            editIndex = null;
            document.getElementById("add").textContent = "Add";
        }

     
        document.getElementById("name").value= '';
        document.getElementById("gender").value = '';
        document.getElementById("age").value = '';
        document.getElementById("email").value= '';
        document.getElementById("province").value = '';
    } else {
        alert("Please fill all the fields");
    }
});


document.getElementById("studentTable").addEventListener("click", function(event) {
    const target = event.target;
    const table = document.getElementById("studentTable").getElementsByTagName('tbody')[0];

    if (event.target.classList.contains("deleteLink")) {
        const row = target.closest("tr");
        row.remove();  // Delete the row
        updateRowNumbers();  // Update row numbers
    }

    if (target.classList.contains("editLink")) {
        const row = target.closest("tr");
        document.getElementById("name").value = row.cells[1].textContent;
        document.getElementById("gender").value = row.cells[2].textContent;
        document.getElementById("age").value = row.cells[3].textContent;
        document.getElementById("email").value = row.cells[4].textContent;
        document.getElementById("province").value = row.cells[5].textContent;

        // Set the index for editing
        editIndex = row.rowIndex;
        document.getElementById("add").textContent = "Save";
    }
});


function updateRowNumbers() {
    const rows = document.querySelectorAll("#studentTable tbody tr ");
    rows.forEach((row, index) => {
        row.cells[0].textContent = index  ;  // Update row number
    });
}